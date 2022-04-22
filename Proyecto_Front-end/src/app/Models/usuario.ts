export interface Usuario {
    login: string;
    id: number;
    avatar_url: string;
    name: string;
    blog: string;
    location: string;
    twitter_username?: any;
    public_repos: number;
    followers: number;
    following: number;
    created_at: Date;
}